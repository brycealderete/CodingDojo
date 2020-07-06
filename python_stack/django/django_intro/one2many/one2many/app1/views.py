from django.shortcuts import render, HttpResponse, redirect
from .models import *

def index(request):
    context={
        "dojo_info": dojo.objects.all(),
        "ninja_info": ninja.objects.all()
    }
    
    return render(request,'index.html',context)

# Create your views here.
def createdojo(request):
    if request.method=='POST':
        adddojo=dojo.objects.create(
            name=request.POST['name'],
            city=request.POST['city'],
            state=request.POST['state'],
            )
        return redirect('/')


def createninja(request):
    if request.method=='POST':
        addninja=ninja.objects.create(
            firstname=request.POST['firstname'],
            lastname=request.POST['lastname'],
            ninja_in_dojo_id=request.POST['ninja_in_dojo']
            )
        return redirect('/')
