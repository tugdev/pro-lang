# -*- coding: cp1254 -*-
## alarm programıdır.kurmak istediğiniz tarihi ve saati ayarlamanız yeterli.
## program internet bağlantısı olmadan tam olarak istenen şekilde çalışmaz.
## internetten herhangi(istenen)bir siteye bağlanıp alarm sesini ordan alıyor. 
## modülleri içe aktarmayı unutmayınız.

from Tkinter import *
import webbrowser
import time
from tkMessageBox import *
pencere=Tk()
pencere.tk_setPalette("#BDFFEE")
pencere.title("ALARMS:)")
pencere.geometry("500x290+400+230")

clock_q =""
gun=time.strftime("%d")
ay=time.strftime("%m")
Yil=time.strftime("%Y")

Label1=Label(text="  ALARM BILGISI GIRINIZ", font=("Comic Sans MS",10,"bold"))
Label1.place(relx=0.105, rely=0.0160, relwidth=0.73, relheight=0.175)

Label2=Label(text="GÜN - AY - YIL")
Label2.place(relx=0.0, rely=0.2065, relwidth=0.4, relheight=0.175)

Entry3=Entry(width=2)
Entry3.place(relx=0.405, rely=0.2065, relwidth=0.05, relheight=0.125)

Entry4=Entry()
Entry4.place(relx=0.455, rely=0.2065, relwidth=0.05, relheight=0.125)

Entry5=Entry()
Entry5.place(relx=0.5, rely=0.2065, relwidth=0.06, relheight=0.125)

Label4=Label(text="SAAT - DAKIKA")
Label4.place(relx=0.0, rely=0.4465, relwidth=0.4, relheight=0.175)

  
Entry6=Entry()
Entry6.place(relx=0.405, rely=0.4465, relwidth=0.05, relheight=0.125)

Entry7=Entry()
Entry7.place(relx=0.455, rely=0.4465, relwidth=0.05, relheight=0.125)



Entry1=Entry(width=2)

Label3=Label(text="UYARICI BILGISI")
Label3.place(relx=0, rely=0.6865, relwidth=0.4, relheight=0.175)

Entry2=Entry(width=2)
Entry2.place(relx=0.405, rely=0.6865, relwidth=0.53, relheight=0.125)

Entry3.insert(0,gun)
Entry4.insert(0,ay)
Entry5.insert(0,Yil)


def ALARM():
    global clock_q
    now = time.strftime("%d.%m.%Y %H:%M")
    if now != clock_q:
        clock_q = now
        Entry1.delete(0,END)
        Entry1.insert(END,clock_q)
        al=Entry1.get()
        al2=Entry2.get()
        al3=Entry3.get()
        al4=Entry4.get()
        al5=Entry5.get()
        al6=Entry6.get()
        al7=Entry7.get()
        al8=(al3+"."+al4+"."+al5+" "+al6+":"+al7)
        if al==al8:
            webbrowser.open_new("http://www.youtube.com/watch?v=5KTAwdEQkRI")   ## istediginiz alarm sesini ayarlayabilirsiniz
            showinfo("NOTUNUZ",al2)
    Entry1.after(200, ALARM)
    pencere.geometry("500x290+400+230")

buton1=Button(text="OK",command=ALARM)
buton1.place(relx=0.395, rely=0.8565, relwidth=0.23, relheight=0.120)

mainloop()
