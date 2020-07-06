from django.urls import path
from . import views

urlpatterns = [
path('',views.index),
path('addbook',views.addbook),
path('createbook',views.createbook),
path('book/<int:bookid>',views.bookinfo),
path('add_author_to_book/<int:bookid>',views.add_author_to_book),
path('createauthor',views.createauthor),
path('addauthor',views.addauthor),
path('add_book_to_author/<int:authorid>',views.add_book_to_author),
path('author/<int:authorid>',views.authorinfo)
]
