from django.db import models
from app1.models import *


class wall_message(models.Model):
    post_message=models.TextField()
    user=models.ForeignKey(user,related_name='wall_messages',on_delete=models.CASCADE)
    

    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)

class wall_comment(models.Model):
    post_comment=models.CharField(max_length=200)
    user=models.ForeignKey(user,related_name='wall_comments',on_delete=models.CASCADE)
    wall_message=models.ForeignKey(wall_message,related_name='wall_comments',on_delete=models.CASCADE)

    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)
