# Generated by Django 2.2.4 on 2020-05-20 17:31

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('app1', '0002_auto_20200519_1252'),
    ]

    operations = [
        migrations.AlterField(
            model_name='user',
            name='firstname',
            field=models.CharField(max_length=30),
        ),
        migrations.AlterField(
            model_name='user',
            name='lastname',
            field=models.CharField(max_length=30),
        ),
        migrations.AlterField(
            model_name='user',
            name='password',
            field=models.CharField(max_length=100),
        ),
    ]
