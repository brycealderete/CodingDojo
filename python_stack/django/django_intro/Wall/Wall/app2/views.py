from django.shortcuts import render, redirect, HttpResponse
from .models import *
from datetime import datetime, timedelta
from django.contrib import messages

# Create your views here.
def wall(request,userid):
    context={
        'user_info':user.objects.get(id=userid),
        'all_messages': wall_message.objects.all().order_by("-id")

    }
    
    if 'userid'not in request.session:
        return redirect('/')
    elif request.session['userid']==userid:
        return render(request,'wall.html',context)
    return redirect('/')

def submit_post(request,userid):
    if 'userid'not in request.session:
        return redirect ('/')
    if request.method =='POST':
        user1=user.objects.get(id=userid)
        message1=wall_message.objects.create(
        post_message=request.POST['post_message'],
        user=user1
    )
    return redirect(f'/wall/{userid}')

def submit_comment(request,userid,messageid):
    if 'userid'not in request.session:
        return redirect ('/')
        
    user1=user.objects.get(id=userid)
    message1=wall_message.objects.get(id=messageid)
    comment1=wall_comment.objects.create(
        post_comment=request.POST['post_message'],
        user=user1,
        wall_message=message1
    )
    return redirect(f'/wall/{userid}')

def delete_message(request,userid,messageid):
    if 'userid'not in request.session:
        return redirect ('/')

    if request.method =='GET':
        message1=wall_message.objects.filter(id=messageid)
        time_threshold = datetime.now() - timedelta(minutes=30)
        results = wall_message.objects.filter(created_at__lt=time_threshold)
        if not message1[0] in results:

        
            if  not message1 or message1[0].user.id != request.session['userid']:
                return redirect(f'/wall/{userid}')
        
            message1.delete()
        messages.error(request, "Unale to delete message over 30 mins old!",extra_tags="over30")
        return redirect(f'/wall/{userid}')
