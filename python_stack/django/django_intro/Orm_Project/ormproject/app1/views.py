from django.shortcuts import render, HttpResponse, redirect
from .models import *

# Create your views here.
def index(request):
    context ={
        "user_info": Users.objects.all()        
    }

    return render(request, "index.html",context)

def create_user(request):
    if request.method=="POST":
        adduser= Users.objects.create(
            firstname=request.POST["firstname"],
            lastname=request.POST["lastname"],
            email=request.POST['email'],
            age=request.POST['age']
            )
        return redirect('/')

