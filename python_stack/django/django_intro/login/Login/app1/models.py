from django.db import models
from django.shortcuts import render, redirect
import bcrypt, re
from datetime import date
from datetime import datetime


class usermanager(models.Manager):
    def validator(self,postdata):
        today = date.today()
        errors = {}
        if len(postdata['firstname'])<2:
            errors['firstname']='This field must be at least 2 characters!'

        if len(postdata['lastname'])<2:
            errors['lastname']='This field must be at least 2 characters!'
        
        bdate = datetime.strptime((postdata['birthday']), '%Y-%m-%d')

        if (today.year - bdate.year - ((today.month, today.day) < (bdate.month, bdate.day)))<13:
            errors['birthday'] = "You must be 13 to access!"

        EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
        if not EMAIL_REGEX.match(postdata['email']):    
            errors['email'] = "Invalid email address!"
        elif len(user.objects.filter(email=postdata["email"]))>0:
            errors['email']='Email already regestered'

        if len(postdata['password'])<7:
            errors['password']='Password must be greater then 7 characters!'
        
        elif not ((postdata['password'])==(postdata['confirmpassword'])):
            errors['password']='Passwords entered do no match!'
            
        
        return errors
    

    

class user(models.Model):
    firstname=models.CharField(max_length=50)
    lastname=models.CharField(max_length=50)
    birthday=models.DateField()
    email=models.CharField(max_length=50)
    password=models.CharField(max_length=60)
    objects=usermanager()

    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)







# Create your models here.
