from django.urls import path
from . import views

urlpatterns = [
path('',views.index),
path ('adduser',views.adduser),
path('login',views.login),
path('success/<int:userid>',views.success),
path('logout',views.logout)
]