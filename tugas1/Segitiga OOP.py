from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W
import math

class FrmSegitiga:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x200")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.Keluar)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label
        Label(mainFrame, text="Panjang Alas:").grid(row=0, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Tinggi:").grid(row=1, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi Miring:").grid(row=3, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=4, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=5, column=0,
        sticky=W, padx=5, pady=5)
        
        # pasang textbox
        self.txtAlas = Entry(mainFrame) 
        self.txtAlas.grid(row=0, column=1, padx=5, pady=5) 
        self.txtTinggi = Entry(mainFrame) 
        self.txtTinggi.grid(row=1, column=1, padx=5, pady=5) 
        self.txtSisi = Entry(mainFrame) 
        self.txtSisi.grid(row=3, column=1, padx=5, pady=5) 
        self.txtLuas = Entry(mainFrame) 
        self.txtLuas.grid(row=4, column=1, padx=5, pady=5) 
        self.txtKeliling = Entry(mainFrame) 
        self.txtKeliling.grid(row=5, column=1, padx=5, pady=5) 

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
        command=self.Hitung)
        self.btnHitung.grid(row=2, column=1, padx=5, pady=5)

    # fungsi untuk menghitung luas dan keliling segitiga
    def Hitung(self, event=None):
       
        alas = int(self.txtAlas.get())
        tinggi = int(self.txtTinggi.get())
        sisimiring = math.sqrt(alas**2 + tinggi**2)
        self.txtSisi.delete(0,END)
        self.txtSisi.insert(END,str(sisimiring))

        segi3 = segitiga(alas, tinggi, sisimiring)
        luas = segi3.luas()
        kel = segi3.keliling()

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        self.txtKeliling.delete(0, END)
        self.txtKeliling.insert(END, str(kel))

    def Keluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()

class segitiga():
    # perhitungan dengan metode Pemrograman OOP
    def __init__(self, alas, tinggi, sisimiring):
        self.alas = alas
        self.tinggi = tinggi
        self.sisi = sisimiring

    def sisimiring(self):
        return math.sqrt(self.alas**2 + self.tinggi**2)

    def luas(self):
        return 0.5 * self.alas * self.tinggi

    def keliling(self):
        return 2 * (self.alas + self.tinggi + self.sisi)

if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmSegitiga(root, "OOP! Program Luas dan Keliling Segitiga")
    root.mainloop()