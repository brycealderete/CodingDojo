from django.urls import path
from . import views

urlpatterns = [
    path('<int:userid>',views.wall),
    path('submit_post/<int:userid>',views.submit_post),
    path('submit_comment/<int:userid>/<int:messageid>',views.submit_comment),
    path('delete_message/<int:userid>/<int:messageid>',views.delete_message)
]
