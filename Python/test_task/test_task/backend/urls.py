from django.urls import path, include
from . import views

urlpatterns = [
	path('', views.get_token),
	path('get_contact/', views.get_contact),
] 