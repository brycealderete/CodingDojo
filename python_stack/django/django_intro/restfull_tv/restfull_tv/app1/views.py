from django.shortcuts import render, redirect
from .models import *
from django.contrib import messages

def index(request):

    return render (request,'index.html')

def createshow(request):
    if request.method=='POST':
        errors=tv_shows.objects.tv_shows_validator(request.POST)
        if len(errors)>0:
            for key, value in errors.items():
                messages.error(request, value,extra_tags=key)
            return redirect('/shows/new')
        newshow=tv_shows.objects.create(
            title=request.POST['title'],
            network=request.POST['network'],
            releasedate=request.POST['releasedate'],
            description=request.POST['description']
        )
        return redirect (f'/shows/{newshow.id}')

def new_show(request, showid):
    context={
    "show_info":tv_shows.objects.get(id=showid)
    }

    return render (request,'showinfo.html',context)

def editshow(request, showid):
    context={
    "show_info":tv_shows.objects.get(id=showid)
    }
    return render (request,'editshow.html',context)

def updateshow(request, showid):
    
    if request.method=='POST':
        errors=tv_shows.objects.tv_shows_validator(request.POST)
        if len(errors)>0:
            for key, value in errors.items():
                messages.error(request, value,extra_tags=key)
            return redirect(f'/shows/{showid}/edit')
        updatedshow=tv_shows.objects.get(id=showid)
        updatedshow.title=request.POST['title']
        updatedshow.network=request.POST['network']
        updatedshow.releasedate=request.POST['releasedate']
        updatedshow.description=request.POST['description']
        updatedshow.save()
    return redirect (f'/shows/{showid}')

def deleteshow(request,showid):
    this_show=tv_shows.objects.get(id=showid)
    this_show.delete()
    return redirect('/shows')

def allshows(request):
    context={
    'show_info':tv_shows.objects.all()
    }
    return render (request, 'allshows.html', context)




# Create your views here.
