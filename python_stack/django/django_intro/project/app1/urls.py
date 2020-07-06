from django.urls import path     
from . import views
urlpatterns = [
    path('', views.index),
    path ('jello', views.new),
    path('create', views.create)
    ]