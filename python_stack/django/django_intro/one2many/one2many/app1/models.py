from django.db import models

# Create your models here.

class dojo(models.Model):
    name= models.CharField(max_length=50)
    city= models.CharField(max_length=50)
    state= models.CharField(max_length=50)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    def __repr__(self):
        return f"{self.id} - {self.name} {self.city} {self.state}"



class ninja(models.Model):
    firstname=models.CharField(max_length=50)
    lastname=models.CharField(max_length=50)
    ninja_in_dojo=models.ForeignKey(dojo, related_name="ninja_location",on_delete=models.CASCADE)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)