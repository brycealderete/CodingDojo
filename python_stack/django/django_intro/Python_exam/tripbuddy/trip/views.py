from django.shortcuts import render


from django.shortcuts import render, redirect, HttpResponse
from .models import *
from django.contrib import messages

# Create your views here.
def dashboard(request,userid):
    
    if 'userid'not in request.session:
        return redirect('/')
    elif request.session['userid']==userid:
        user1=user.objects.get(id=userid)
        context={
        'user1':user.objects.get(id=userid),
        'all_trips': Trips.objects.all().order_by("-id"),
        'user_trips':user1.trips_owned

    }
        return render(request,'dashboard.html',context)
    return redirect('/')

def createtrip(request,userid):
    if 'userid'not in request.session:
        return redirect ('/')
    context={
        'user1':user.objects.get(id=userid)
    }
    return render(request,'newtrip.html',context)

def addtrip(request):
    userid=request.session['userid']
    if 'userid'not in request.session:
        return redirect ('/')
    if request.method =='POST':
        user1=user.objects.get(id=userid)
        errors=Trips.objects.val(request.POST)
        if len(errors)>0:
            for key, value in errors.items():
                messages.error(request, value,extra_tags=key)
                return redirect(f'/trip/create_trip/{userid}')
        trip1=Trips.objects.create(
        destination=request.POST['destination'],
        start_date=request.POST['start_date'],
        end_date=request.POST['end_date'],
        plan=request.POST['plan'],
        owner=user1
    )
        user1.join_trip.add(trip1)
        return redirect(f'/trip/{userid}')
    return redirect(f'/trip/{userid}')

def edit(request,tripid):
    if "userid" not in request.session:
        return redirect("/")
    trip1= Trips.objects.filter(id=tripid)
    if not trip1 or trip1[0].owner.id != request.session["userid"]:
        return redirect("/")
    userid=request.session['userid']
        
    context = {
        "trip1": trip1[0],
        'user1':user.objects.get(id=userid)
    }
    return render(request, "edittrip.html", context)

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

def join(request, tripid, dashboard):
    user1=user.objects.get(id=request.session["userid"]
    trip1=Trips.objects.get(id=tripid)
    if (user1) not in Trip.objects.get(id=number).participants.all()) and (request.session["id"] != Trip.objects.get(id=number).creator.id):
        Trip.objects.get(id=number).participants.add(request.session['id'])
    if dashboard == "0":
        return redirect('/travels/destination/'+number)


# Create your views here.
