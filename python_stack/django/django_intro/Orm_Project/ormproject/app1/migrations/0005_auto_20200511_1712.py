# Generated by Django 2.2.4 on 2020-05-12 00:12

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('app1', '0004_auto_20200511_1708'),
    ]

    operations = [
        migrations.RenameModel(
            old_name='User',
            new_name='Users',
        ),
    ]