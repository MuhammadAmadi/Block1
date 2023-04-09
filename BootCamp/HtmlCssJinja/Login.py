from flask_wtf import FlaskForm
from wtforms import StringField, PasswordField, BooleanField, SubmitField, EmailField
from wtforms.validators import DataRequired

class Login(FlaskForm):
    email = EmailField("Почта", validators = [DataRequired()])
    password = PasswordField("Пароль", validators = [DataRequired()])
    saveMe = BooleanField("Запомнить")
    submit = SubmitField("Авторизироваться")