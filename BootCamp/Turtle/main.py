import turtle
import random


w = 700
h = 500
trtl = turtle.Turtle()
window = turtle.Screen()
window.bgcolor('black')
window.setup(w, h)


def star_fill(count, line_length):
    trtl.begin_fill()
    turtle_method(count=count, line_length=line_length)
    trtl.end_fill()


def turtle_method(count, line_length, star=True):
    if star and count % 2 != 0:
        var_angle = count // 2 * 360 / count
    else:
        var_angle = 360 / count
    for _i in range(count):
        trtl.forward(line_length)
        trtl.right(var_angle)


cnt = 3
trtl.speed(100)

trtl.color('yellow')
for i in range(500):
    line_length = random.randint(5,15)
    rnd = random.choice([5, 7, 9])
    x = random.randint(line_length-h//2, h//2-line_length)
    y = random.randint(line_length-w//2, w//2-line_length)
    trtl.penup()
    trtl.setposition(y, x)
    trtl.pendown()
    star_fill(rnd, line_length,)


turtle.done()