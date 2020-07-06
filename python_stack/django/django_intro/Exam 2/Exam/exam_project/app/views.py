from django.shortcuts import render


from django.shortcuts import render, redirect, HttpResponse
from .models import *
from datetime import datetime, timedelta
from django.contrib import messages

# Create your views here.
def dashboard(request,userid):
    
    if 'userid'not in request.session:
        return redirect('/')
    elif request.session['userid']==userid:
        context={
        'user_info':user.objects.get(id=userid),
        'all_quotes': quotes.objects.all().order_by("-id")

    }
        return render(request,'dashboard.html',context)
    return redirect('/')

def addquote(request):
    if 'userid'not in request.session:
        return redirect ('/')
    if request.method =='POST':
        userid=request.session['userid']
        errors=quotes.objects.val(request.POST)
        if len(errors)>0:
            for key, value in errors.items():
                messages.error(request, value,extra_tags=key)
            return redirect(f"/dashboard/{userid}")

        quote1=quotes.objects.create(
        quote=request.POST['quote'],
        author=request.POST['author'],
        rating=0,
        user_id=request.session['userid']
        )
    return redirect(f'/dashboard/{userid}')

def edit(request,userid):
    if "userid" not in request.session:
        return redirect("/")
    user1= user.objects.filter(id=userid)
    if not user1 or user1[0].id != request.session["userid"]:
        return redirect("/")
    context = {
        "user1": user1[0]
    }
    return render(request, "edituser.html", context)

def edituser(request,userid):
    if "userid" not in request.session:
        return redirect("/")
    if request.method == "POST":
        user1 = user.objects.filter(id=userid)

        if not user1 or user1[0].id != request.session["userid"]:
            return redirect("/")

        errors = user.objects.edit_val(request.POST,userid)

        if len(errors) > 0:
            for key, value in errors.items():
                messages.error(request, value, extra_tags=key)
            return redirect(f"/dashboard/{userid}/edit")
        
        user1[0].firstname = request.POST["firstname"]
        user1[0].lastname = request.POST["lastname"]
        user1[0].email = request.POST["email"]
        user1[0].save()

        return redirect(f"/dashboard/{userid}/edit")
    return redirect("/")

def delete(request,quoteid):
    if 'userid'not in request.session:
        return redirect ('/')

    if request.method =='POST':
        userid=request.session['userid']
        quote1=quotes.objects.filter(id=quoteid)

        if  not quote1 or quote1[0].user.id != request.session['userid']:
            return redirect(f'/dashboard/{userid}')
        
        quote1.delete()
        return redirect(f'/dashboard/{userid}')

def profile(request,userid):
    if 'userid'not in request.session:
        return redirect ('/')
    user1=user.objects.filter(id=userid)
    context={
        'user1':user1[0],
        'all_quotes': quotes.objects.all().order_by("-id")
    }
    return render(request,'profile.html',context)