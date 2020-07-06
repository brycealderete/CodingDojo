from django.shortcuts import render
from time import gmtime, strftime
from django.utils.crypto import get_random_string
    
def index(request):
    context = {
        "time": strftime("%Y-%m-%d %H:%M %p", gmtime())
    }
    return render(request,'index.html', context)

def get_random_string(request):
    context = {
        "random": 
    }


# Create your views here.
