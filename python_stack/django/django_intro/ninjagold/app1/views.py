from django.shortcuts import render, HttpResponse, redirect
import random

def index(request):
    if 'gold' not in request.session:
        request.session['gold'] = 0
    return render(request, "index.html")
def process_money(request):
    if request.POST['gold'] == 'farm':
        request.session['gold'] += random.randint(10,20)
    if request.POST['gold'] == 'cave':
        request.session['gold'] += random.randint(5,10)
    if request.POST['gold'] == 'house':
        request.session['gold'] += random.randint(2,5)
    if request.POST['gold'] == 'casino':
        request.session['gold'] += random.randint(-50,50)
    
    

    
    
    return redirect("/")