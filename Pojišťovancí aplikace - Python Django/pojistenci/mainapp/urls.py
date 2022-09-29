"""pojistenci URL Configuration

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/4.1/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""

from django.urls import path
from . import views

urlpatterns = [
    path('',views.index.as_view(), name="index"),
    path('pojisteni/',views.PojisteniListView.as_view(),name="pojisteni"),
    path('vytvor_pojisteni/',views.CreatePojisteni.as_view(),name="vytvor_pojisteni"),
    path('vytvor_pojistence/',views.CreatePojistence.as_view(),name="vytvor_pojistence"),
    path('<int:pk>/detail_pojistence/',views.CurrentDetailPojistenec.as_view(),name="detail_pojistence"),
    path('<int:pk>/detail_pojisteni/',views.CurrentDetailPojisteni.as_view(),name="detail_pojisteni"),
    path("registrace/",views.UzivatelViewRegistrace.as_view(),name="registrace"),
    path("login/",views.UzivatelViewLogin.as_view(),name="login"),
    path("logout/",views.logout_user,name="logout"),
    path("<int:pk>/uprav_pojistence/",views.EditPojistence.as_view(),name="uprav_pojistence"),
    path("<int:pk>/zaloz_pojisteni/",views.ZalozPojisteni.as_view(),name="zaloz_pojisteni"),
    path("<int:pk>/uprav_pojisteni/",views.EditPojistky.as_view(),name="uprav_pojisteni"),
    path("o_aplikaci/",views.about.as_view(),name="o_aplikaci")

]
