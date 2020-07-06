# Generated by Django 2.2.4 on 2020-05-26 19:36

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('login', '0001_initial'),
        ('trip', '0003_auto_20200526_1232'),
    ]

    operations = [
        migrations.AddField(
            model_name='trips',
            name='join',
            field=models.ManyToManyField(related_name='join_trip', to='login.user'),
        ),
        migrations.DeleteModel(
            name='Join',
        ),
    ]