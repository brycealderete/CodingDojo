from django.urls import path
from . import views

urlpatterns = [
    path('<int:userid>',views.dashboard),
    path('addquote',views.addquote),
    path('<int:userid>/edit',views.edit),
    path('<int:userid>/edituser',views.edituser),
    path('<int:userid>/profile',views.profile),
    path('delete/<int:quoteid>',views.delete),

]
