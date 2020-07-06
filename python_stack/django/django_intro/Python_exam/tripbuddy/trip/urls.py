from django.urls import path
from . import views

urlpatterns = [
    path('<int:userid>',views.dashboard),
    path('create_trip/<int:userid>',views.createtrip),
    path('addtrip',views.addtrip),
    path('Edittrip/<int:tripid>',views.edit),
    path('jointrip/<int:tripid>',views.join),


]