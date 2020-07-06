from django.db import models

class book(models.Model):
    title=models.CharField(max_length=100)
    description=models.TextField()

    created_at=models.DateTimeField(auto_now_add=True)
    updated_at=models.DateTimeField(auto_now=True)


class author(models.Model):
    firstname=models.CharField(max_length=100)
    lastname=models.CharField(max_length=100)
    notes=models.TextField()
    books=models.ManyToManyField(book, related_name="authors")

    created_at=models.DateTimeField(auto_now_add=True)
    updated_at=models.DateTimeField(auto_now=True)



# Create your models here.
