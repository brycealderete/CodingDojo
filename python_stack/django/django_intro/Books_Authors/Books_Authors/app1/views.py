from django.shortcuts import render, redirect
from .models import *

def index(request):
    context={
        'book_info':book.objects.all()
    }
    
    return render (request,'index.html',context)

def addbook(request):
    context={
        'book_info':book.objects.all()
    }
    return render (request,'addbook.html', context)

def createbook(request):
    context={
        'book_info':book.objects.all()
    }
    if request.method == 'POST':
        
        addbook= book.objects.create(
            title=request.POST['title'],
            description=request.POST['description']
        )
    return redirect ('/addbook')

def bookinfo(request,bookid):
    context={
        'book_info':book.objects.get(id=bookid),
        'author_info':author.objects.all()
    }
    return render (request,'book.html',context)

def add_author_to_book(request, bookid):
    thisbook=book.objects.get(id=bookid)
    thisauthor=author.objects.get(id=request.POST["authors"])
    if request.method=='POST':
        addauthor=thisbook.authors.add(thisauthor)
    return redirect (f'/book/{bookid}')

def createauthor(request):
    if request.method == 'POST':
        
        addauthor= author.objects.create(
            firstname=request.POST['firstname'],
            lastname=request.POST['lastname'],
            notes=request.POST['notes']
        )
    return redirect ('/addauthor')

def addauthor(request):
    context={
        'author_info':author.objects.all()
    }
    return render (request,'addauthor.html', context)


def add_book_to_author(request, authorid):
    thisbook=book.objects.get(id=request.POST['books'])
    thisauthor=author.objects.get(id=authorid)
    if request.method=='POST':
        addbook=thisauthor.books.add(thisbook)
    return redirect (f'/author/{authorid}')
    

def authorinfo(request,authorid):
    context={
        'author_info':author.objects.get(id=authorid),
        'book_info':book.objects.all()
    }
    return render (request,'author.html',context)


    # Create your views here.
