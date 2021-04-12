from flask_wtf import FlaskForm
from wtforms import  TextAreaField, SubmitField,  StringField, PasswordField, BooleanField, DateTimeField
from wtforms import validators
from wtforms.ext.sqlalchemy.fields import QuerySelectField
from wtforms.validators import InputRequired, Email, Length, EqualTo


def get_category():
    from app import Category
    return Category.query.all()

def get_author():
    from app import Author
    return Author.query.all()



class BookForm(FlaskForm):
    title = StringField("Name Of title", [validators.DataRequired("Please enter title.")], unique=True)
    description = TextAreaField("cont", [validators.DataRequired("Please enter title.")])
    category = QuerySelectField('Category', [validators.DataRequired(u'Please select a Category')],query_factory=get_category, get_label='name', allow_blank=True)
    author = QuerySelectField('Author', [validators.DataRequired(u'Please select a Author')],query_factory=get_author, get_label='name', allow_blank=True)
    submit = SubmitField("Submit")

class SignUpForm(FlaskForm):
    username = StringField('username_label',
        validators=[InputRequired(), Length(min=4, max=15, message="Username must be between 4 and 15 characters")])
    email = StringField('email_label', validators=[InputRequired(), Email(message='Invalid email'), Length(max=50)])
    password = PasswordField('password_label',
        validators=[InputRequired(), Length(min=6, max=15, message="Password must be between 6 and 15 characters")])
    confirm_pswd = PasswordField('confirm_pswd_label', validators=[InputRequired(), EqualTo('password', message="passwords must match")])
    user_agree = BooleanField('agreement')
    submit_button = SubmitField('Sign Up')



