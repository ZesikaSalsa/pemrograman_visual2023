from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W
import math

class FrmLingkaran:
    def __init__(self, parent, title):
        self.parent = parent 
        self.parent.geometry("400x200")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label
        Label(mainFrame, text='Jari-jari:').grid(row=0, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=2, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=3, column=0,
        sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtJari = Entry(mainFrame) 
        self.txtJari.grid(row=0, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame) 
        self.txtLuas.grid(row=2, column=1, padx=5, pady=5) 
        self.txtKeliling = Entry(mainFrame) 
        self.txtKeliling.grid(row=3, column=1, padx=5, pady=5) 

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
        command=self.onHitung)
        self.btnHitung.grid(row=1, column=1, padx=5, pady=5)
    
    # fungsi untuk menghitung luas dan keliling lingkaran 
    def onHitung(self, event=None):
    
        # perhitungan dengan metode Pemrograman Tidak Terstruktur 
        jarijari = int(self.txtJari.get())

        ling = lingkaran(jarijari)
        luas = ling.luas()
        kel = ling.keliling()

        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))
        
    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()

class lingkaran():
    # perhitungan dengan metode Pemrograman OOP
    def __init__(self, jarijari):
        self.jari = jarijari

    def luas(self):
        return math.pi * self.jari**2

    def keliling(self):
        return 2 * math.pi * self.jari

if __name__ == '__main__':
    root = Tk() 
    aplikasi = FrmLingkaran(root, "(OOP) Program Luas dan Keliling Lingkaran")
    root.mainloop()