# Generated by Django 2.2.4 on 2020-05-19 22:22

from django.db import migrations, models
import django.utils.timezone


class Migration(migrations.Migration):

    dependencies = [
        ('app2', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='wall_message',
            name='post_message',
            field=models.TextField(default=django.utils.timezone.now),
            preserve_default=False,
        ),
    ]