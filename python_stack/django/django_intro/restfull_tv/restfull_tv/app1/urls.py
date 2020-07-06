from django.urls import path
from . import views

urlpatterns = [
    path('new',views.index),
    path('create',views.createshow),
    path('<int:showid>',views.new_show),
    path('<int:showid>/edit',views.editshow),
    path('<int:showid>/update',views.updateshow),
    path('<int:showid>/delete',views.deleteshow),
    path('',views.allshows)
]