# Generated by Django 4.1 on 2022-09-13 14:10

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('mainapp', '0001_initial'),
    ]

    operations = [
        migrations.AlterField(
            model_name='pojistenec',
            name='email',
            field=models.CharField(max_length=80, unique=True),
        ),
    ]
