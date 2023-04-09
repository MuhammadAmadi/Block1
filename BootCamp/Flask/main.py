# from flask import Flask

# app = Flask(__name__)

# @app.route('/')
# def main():
#     return "<h1>Hello world!</h1><br><a href = '/index'><h3>Перейти на следующую страницу</h3></a>"

# @app.route('/index')
# def index():
#     return "<h1>Мой первый проект<h1><br><a href = '/'><h3>Перейти на главную страницу</h3></a>"

# @app.route('/index/<x>/<y>')
# def indexCalc(x,y):
#     return f"<h1>Результат: = {int(x) + int(y)}<h1><br><a href = '/'><h3>Перейти на главную страницу</h3></a>"

# if __name__ == '__main__':
#     app.run()