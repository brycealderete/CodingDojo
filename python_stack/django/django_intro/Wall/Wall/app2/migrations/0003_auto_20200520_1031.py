# Generated by Django 2.2.4 on 2020-05-20 17:31

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('app2', '0002_wall_message_post_message'),
    ]

    operations = [
        migrations.AlterField(
            model_name='wall_comment',
            name='user',
            field=models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, related_name='wall_comments', to='app1.user'),
        ),
    ]