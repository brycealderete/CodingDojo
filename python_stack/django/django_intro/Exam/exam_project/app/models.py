from django.db import models
from login.models import *
# Create your models here.

class quotemanager(models.Manager):
    def val(self,postdata):
        errors = {}
        if len(postdata['author'])<3:
            errors['author']='Author must be more than 3 characters'

        if len(postdata['quote'])<10:
            errors['quote']='quote must be more than 10 characters'
        return errors

class quotes(models.Model):
    quote=models.CharField(max_length=500)
    author=models.CharField(max_length=50)
    user=models.ForeignKey(user,related_name='quote',on_delete=models.CASCADE)
    objects=quotemanager()

    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)