from django.contrib import admin
from django import forms
from .models import Pojisteni, Pojistenec, Uzivatel, UzivatelskyManager,ZalozenaPojisteni
from django.contrib.auth.admin import UserAdmin
from django.contrib.auth.forms import ReadOnlyPasswordHashField

# Register your models here.

admin.site.register(Pojisteni)
admin.site.register(Pojistenec)
admin.site.register(ZalozenaPojisteni)


class UzivatelCreationForm(forms.ModelForm):
    password = forms.CharField(label='Password', widget = forms.PasswordInput)

    class Meta:
        model = Uzivatel
        fields = ['email']

    def save(self, commit=True):
        if self.is_valid():
            user = super().save(commit=False)
            user.set_password(self.cleaned_data["password"])
            if commit:
                user.save()
            return user


class UzivatelChange(forms.ModelForm):
    password = ReadOnlyPasswordHashField()

    class Meta:
        model = Uzivatel
        fields = ['email','is_admin']

        def __init__(self, *args, **kwargs):
            super(UzivatelChangeForm, self).__init__(*args, **kwargs)
            self.Meta.fields.remove('password')


class UzivatelAdmin(UserAdmin):
    form = UzivatelChange
    add_form = UzivatelCreationForm

    list_display = ['email', 'is_admin']
    list_filter = ['is_admin']
    fieldsets = (
        (None, {'fields': ['email', 'password']}),
        ('Permissions', {'fields': ['is_admin']}),
    )

    add_fieldsets = (
        (None, {
            'fields': ['email', 'password']}
        ),
    )
    search_fields = ['email']
    ordering = ['email']
    filter_horizontal = []

admin.site.register(Uzivatel,UzivatelAdmin)
