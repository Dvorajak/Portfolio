# Generated by Django 4.1 on 2022-09-13 14:11

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('mainapp', '0002_alter_pojistenec_email'),
    ]

    operations = [
        migrations.AlterField(
            model_name='pojistenec',
            name='email',
            field=models.EmailField(max_length=80),
        ),
    ]
