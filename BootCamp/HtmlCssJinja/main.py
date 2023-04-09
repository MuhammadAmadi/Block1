from flask import Flask, render_template
from Register import Reg
from Login import Login

app = Flask(__name__)
app.config['SECRET_KEY'] = 'dek hell raft asus bay smart world'

@app.route('/')
def main():
    dataList = list()
    with open('file.txt','r', encoding='utf-8') as file:
        for line in file.readlines():
            dataList.append(tuple(line.split('\n')[0].split(';')))

    return render_template('base.html', title='Главная страница', data = dataList)

@app.route('/about')
def about():
    return render_template('about.html', title='О нас')

@app.route('/register', methods = ['GET','POST'])
def reg():
    form = Reg()
    if form.validate_on_submit():
        if form.passwordRepeat.data != form.password.data:
            return render_template('register.html', title='Регистрация',
                                   form=form, message = 'пароли не совпадают')
        else:
            with open('bd.txt','r', encoding='utf-8') as bd:
                data = ' '.join(bd.readlines())
            if form.email.data not in data:
                with open('bd.txt','a', encoding='utf-8') as bd:
                    bd.write(f'{form.name.data};{form.email.data};{form.password.data}\n')
            else:
                return render_template('register.html', title='Регистрация',form=form,
                                       message = 'Пользователь с таким e-mail уже зарегистрирован')
        return render_template('register.html', title='Регистрация', message = 'Успех')
    

    return render_template('register.html', title='Регистрация', form=form)

@app.route('/login', methods = ['GET','POST'])
def login():
    form = Login()
    if form.validate_on_submit():
        with open('bd.txt', 'r', encoding='utf-8') as bd:
            data = ' '.join(bd.readlines())
            
        if form.email.data not in data:
                return render_template('register.html', title='Авторизация', form=form,
                                       message = 'неверный логин или пароль')
        else:
            for i in data.split():
                if form.email.data in i:
                    if i.split(';')[-1] == form.password.data:
                        return render_template('login.html', title='Авторизация',
                                               message = 'Авторизация прошла успешно')
    

    return render_template('login.html', title='Авторизация', form=form)

if __name__ == '__main__':
    app.run()
