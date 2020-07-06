from django.shortcuts import render,HttpResponse,redirect



def index(request):
    return render(request,"index.html")
def new(request):
    return HttpResponse("placeholder to display a new form to create a new blog")
def create(request):
    return redirect('')

# Create your views here.
