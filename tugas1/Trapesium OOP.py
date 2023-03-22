from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W

class FrmTrapesium:
    def __init__(self, parent, title):
        self.parent = parent 
        self.parent.geometry("400x400")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label
        Label(mainFrame, text='Sisi A:').grid(row=1, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi B:').grid(row=2, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi C:').grid(row=3, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi D:').grid(row=4, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Tinggi:").grid(row=5, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=7, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=8, column=0,sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtSisi_A = Entry(mainFrame) 
        self.txtSisi_A.grid(row=1, column=1, padx=5, pady=5)
        self.txtSisi_B = Entry(mainFrame) 
        self.txtSisi_B.grid(row=2, column=1, padx=5, pady=5)
        self.txtSisi_C = Entry(mainFrame) 
        self.txtSisi_C.grid(row=3, column=1, padx=5, pady=5)
        self.txtSisi_D = Entry(mainFrame) 
        self.txtSisi_D.grid(row=4, column=1, padx=5, pady=5)
        self.txtTinggi = Entry(mainFrame) 
        self.txtTinggi.grid(row=5, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame) 
        self.txtLuas.grid(row=7, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame) 
        self.txtKeliling.grid(row=8, column=1, padx=5, pady=5) 

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',command=self.onHitung)
        self.btnHitung.grid(row=6, column=1, padx=5, pady=5)

    # fungsi untuk menghitung luas dan keliling trapesium 
    def onHitung(self, event=None):
        
        # perhitungan dengan metode Pemrograman Tidak Terstruktur 
        sisi_a = int(self.txtSisi_A.get())
        sisi_b = int(self.txtSisi_B.get())
        sisi_c = int(self.txtSisi_C.get())
        sisi_d = int(self.txtSisi_D.get())
        tinggi = int(self.txtTinggi.get())

        trap = trapesium(sisi_a, sisi_b, sisi_c, sisi_d, tinggi)
        luas = trap.luas()
        kel = trap.keliling()

        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))

    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()

class trapesium():
    # perhitungan dengan metode Pemrograman OOP
    def __init__(self, sisi_a, sisi_b, sisi_c, sisi_d, tinggi):
        self.sisi_a = sisi_a
        self.sisi_b = sisi_b
        self.sisi_c = sisi_c
        self.sisi_d = sisi_d
        self.tinggi = tinggi

    def luas(self):
        return 0.5 * (self.sisi_a + self.sisi_b) * self.tinggi

    def keliling(self):
        return self.sisi_a + self.sisi_b + self.sisi_c + self.sisi_d

if __name__ == '__main__':
    root = Tk() 
    aplikasi = FrmTrapesium(root, "(OOP) Program Luas dan Keliling Trapesium")
    root.mainloop()