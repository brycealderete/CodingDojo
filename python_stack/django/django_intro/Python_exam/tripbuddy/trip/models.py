from django.db import models
from login.models import *
# Create your models here.
class Trips_manager(models.Manager):
    def val(self,postdata):
        errors = {}
        if len(postdata['destination'])<3:
            errors['destination']='Destination must be more than 3 characters'

        if len(postdata['plan'])<3:
            errors['plan']='Plan must be more than 3 characters'
        return errors

class Trips(models.Model):
    destination=models.CharField(max_length=200)
    start_date=models.DateField()
    end_date=models.DateField()
    plan=models.TextField()
    owner = models.ForeignKey(user, related_name="trips_owned", on_delete=models.CASCADE)
    join=models.ManyToManyField(user, related_name="join_trip")
    objects=Trips_manager()

    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)
