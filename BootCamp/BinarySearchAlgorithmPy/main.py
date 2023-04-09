import random
from tkinter import *


region_budget = [9.95, 3.16, 57.05, 10.485, 11.97, 18.17, 13.425, 3.28, 18.16]
federation_budget = 55.83
acceptable_average_profit = 11
acceptable_risk = 1
costs = []
risk = []
marja = []
name = []
# 0 region
costs.append([10.42, 9.48])
risk.append([2.73, 1.63])
marja.append([15.31, 14.68])
name.append(["реконструкция офисных зданий и сооружений",
             "выделение группы технологичесского аудита в обособленную структуру"])
# 1 region
costs.append([7.32])
risk.append([1.7])
marja.append([14.77])
name.append(["разработка и внедрение специальных средств упаковки ценных грузов"])
# 2 region
costs.append([11.31, 10.85, 13.51, 10.87])
risk.append([1.52, 1.6, 2.32, 1.12])
marja.append([14.03, 15.76, 15.7, 13.08])
name.append(["приобретение и оборудование бронеавтомобилей",
             "разработка и внедрение специальных средств упаковки ценных грузов",
             "установка спутниковых датчиков GPS по отслеживанию выполнения маршрута",
             "приобретение и доукомплектование грузового и легкового автотранспорта"])
# 3 region
costs.append([6.38, 14.59])
risk.append([1.44, 2.83])
marja.append([15.25, 14.49])
name.append(["приобретение и доукомплектование грузового и легкового автотранспорта",
             "сдача в аренду сторонним организациям части площадей"])
# 4 region
costs.append([13.71, 10.23])
risk.append([1.73, 1.42])
marja.append([13.39, 14.95])
name.append(["приобретение и доукомплектование грузового и легкового автотранспорта",
             "установка спутниковых датчиков GPS по отслеживанию выполнения маршрута"])
# 5 region
costs.append([13.16, 12.15, 11.03])
risk.append([1.19, 2.54, 1.51])
marja.append([17.39, 13.18, 13.27])
name.append(["закупка запчастей", "реконструкция офисных зданий и сооружений",
             "приобретение и оборудование бронеавтомобилей"])
# 6 region
costs.append([14.95, 11.9])
risk.append([2.57, 2.63])
marja.append([17.05, 16.81])
name.append(["переход на заправки по топливным картам отказ от заправок за наличные средства",
             "установка спутниковых датчиков GPS по отслеживанию выполнения маршрута"])
# 7 region
costs.append([6.56])
risk.append([2.24])
marja.append([14.41])
name.append(["приобретение и оборудование бронеавтомобилей"])
# 8 region
costs.append([11.55, 13.69, 11.08])
risk.append([1.05, 1.08, 1.14])
marja.append([13.93, 14.05, 16.41])
name.append(["приобретение базы (г.Находка)", "приобретение и доукомплектование грузового и легкового автотранспорта",
             "разработка и внедрение специальных средств упаковки ценных грузов"])

projects_in_region = [2, 1, 4, 2, 2, 3, 2, 1, 3]
regions = 9

count_populations = 10000
count_generations = 10000

populations = []
generations = []

up_cost = 0
winners = []


def first_generation(len_pop):
    global generations
    # print(f"поколении {generations}")
    for cp in range(count_populations - len_pop):
        generation = []
        # print(f"поколение {generation}")
        for r in range(regions):
            project = []
            # print(f"проект {pr}")
            for pg in range(projects_in_region[r]):
                project.append(random.randint(0, 1))
            # print(f"проект {pr}")
            generation.append(project)
            # print(f"поколение {generation}")
        generations.append(generation)
        # print(f"поколении {generations}")


def fitness(generation):
    profit = 0
    for r in range(regions):
        for g in range(len(generation[r])):
            profit = profit + generation[r][g] * marja[r][g]

    return profit


def seek_max():
    profit_max = 0
    for cp in range(count_populations):
        profit = fitness(generations[cp])
        if profit > profit_max:
            profit_max = profit
    return profit_max


def up_limit():
    global up_cost
    up_cost = federation_budget
    for rb in region_budget:
        # print(rb)
        up_cost += rb
        # print(region_budget[0])
        # up_cost += region_budget[0]


def test_costs(x):
    price = 0
    for r in range(regions):
        for lx in range(len(x[r])):
            price += x[r][lx] * costs[r][lx]
    return price


def test_one_project(x):
    rez = True
    for r in range(regions):
        s = 0
        for lx in range(len(x[r])):
            s += x[r][lx]
        if s == 0:
            rez = False
    return rez


def new_generation():
    global generations
    old_generations = generations.copy()
    profit_max = seek_max()
    generations = []
    for cp in range(count_populations):
        if (fitness(old_generations[cp]) >= 0.8 * profit_max and test_costs(old_generations[cp]) <= up_cost
                and test_one_project(old_generations[cp])):
            generations.append(old_generations[cp])
    first_generation(len(generations))


def seek_winner():
    winner = []
    for cp in range(count_populations):
        if (fitness(generations[cp]) >= seek_max() * 0.5 and
                test_costs(generations[cp]) <= up_cost and test_one_project(generations[cp])):
            winner.append([generations[cp], fitness(generations[cp])])
    max_cf = 0
    for w in winner:
        if w[1] > max_cf:
            return w[0]


up_limit()
first_generation(0)
# print(generations[0])
new_generation()

for cg in range(count_generations):
    new_generation()

winners = seek_winner()
print(winners)
print(f"Прибыль от победителя {fitness(winners)}")
print(f"затраты на реализацию проектов победителя {test_costs(winners)}")
print(f"лимит трат на реализацию {up_cost}")

root = Tk()

out = list()
out.append(["Прибыль", "Риск", "Стоимость", "Название проекта", "ЦФО", "Одобрен"])


def fill_out():
    global out
    sum_cost = 0
    sum_marja = 0
    count_projects = 0
    for r in range(regions):
        out.append(["", "", "", "ЦФО № "+str(r), "", ""])
        for pr in range(projects_in_region[r]):
            if winners[r][pr] == 1:
                txt = "ДА"
                count_projects += 1
                sum_cost += costs[r][pr]
                sum_marja += marja[r][pr]
            else:
                txt = "НЕТ"
            out.append([marja[r][pr], risk[r][pr], costs[r][pr], name[r][pr], r, txt])
    out.append([str(round(sum_marja, 2)), "", str(round(sum_cost, 2)), "ВССЕГО ОДОБРЕНО " + str(count_projects) +
               " ПРОЕКТОВ, ЛИМИТ ДЕНЕГ РАВЕН " + str(round(up_cost, 2)), "", ""])


fill_out()

root.title("Портфель инвестиций")
for i in range(len(out)):
    for j in range(6):
        lb = Label(text=str(out[i][j]), relief=RIDGE)
        lb.grid(row=i, column=j, sticky=NSEW)

root.mainloop()
