from flask_wtf import FlaskForm
from wtforms import  TextAreaField, SubmitField,  StringField, PasswordField, BooleanField
from wtforms import validators
from wtforms.ext.sqlalchemy.fields import QuerySelectField
from wtforms.validators import InputRequired, Email, Length, EqualTo
from wtforms.fields.html5 import DateTimeLocalField

def get_theme():
    from app import Theme
    return Theme.query.all()

def get_tags():
    from app import Tags
    return Tags.query.all()

def get_users():
    from app import User
    return Author.query.all()

class PostForm(FlaskForm):
    title = StringField("Name Of title", [validators.DataRequired("Please enter title.")], unique=True)
    body = TextAreaField("Body", [validators.DataRequired("Please enter body.")])
    author = StringField("Name Of author", [validators.DataRequired("Please enter title.")])
    timestamp = DateTimeLocalField()
    theme = QuerySelectField('Theme', [validators.DataRequired(u'Please select a Theme')], query_factory=get_theme, get_label='title', allow_blank=True)
    tag = QuerySelectField('Tag', [validators.DataRequired(u'Please select a Tag')], query_factory=get_tags, get_label='title', allow_blank=True)
    submit = SubmitField("Submit")