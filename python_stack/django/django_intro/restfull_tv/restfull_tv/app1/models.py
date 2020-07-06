from django.db import models

class tv_shows_manager(models.Manager):
    def tv_shows_validator(self,postdata):
        errors = {}
        if len(postdata['title'])==0:
            errors['title']='You cannot leave this field blank'

        if len(postdata['network'])==0:
            errors['network']='You cannot leave this field blank'

        if len(postdata['releasedate'])==0:
            errors['releasedate']='You cannot leave this field blank'

        if len(postdata['description'])==0:
            errors['description']='You cannot leave this field blank'
        
        return errors

    


class tv_shows(models.Model):
    title=models.CharField(max_length=100)
    network=models.CharField(max_length=100)
    releasedate=models.DateField()
    description=models.TextField()
    objects=tv_shows_manager()


    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
# Create your models here.
