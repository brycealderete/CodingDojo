from django.urls import path
from . import views

urlpatterns = [
path ('',views.index),
path ('createdojo',views.createdojo),
path ('createninja', views.createninja)
]