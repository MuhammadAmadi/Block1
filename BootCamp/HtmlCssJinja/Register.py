from flask_wtf import FlaskForm
from wtforms import StringField, PasswordField, BooleanField, SubmitField, EmailField
from wtforms.validators import DataRequired

class Reg(FlaskForm):
    name = StringField("Имя", validators = [DataRequired()])
    email = EmailField("Почта", validators = [DataRequired()])
    password = PasswordField("Пароль", validators = [DataRequired()])
    passwordRepeat = PasswordField("Повторить пароль", validators = [DataRequired()])
    saveMe = BooleanField("Запомнить")
    submit = SubmitField("Зарегистрироваться")
