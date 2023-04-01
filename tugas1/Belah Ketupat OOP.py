from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W

class FrmBelah_Ketupat:
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
        Label(mainFrame, text='Diagonal 1:').grid(row=1, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Diagonal 2:').grid(row=2, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Panjang Sisi:').grid(row=3, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=5, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=6, column=0,sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtDiagonal_1 = Entry(mainFrame) 
        self.txtDiagonal_1.grid(row=1, column=1, padx=5, pady=5)
        self.txtDiagonal_2 = Entry(mainFrame) 
        self.txtDiagonal_2.grid(row=2, column=1, padx=5, pady=5)
        self.txtSisi = Entry(mainFrame) 
        self.txtSisi.grid(row=3, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame) 
        self.txtLuas.grid(row=5, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame) 
        self.txtKeliling.grid(row=6, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',command=self.onHitung)
        self.btnHitung.grid(row=4, column=1, padx=5, pady=5)

    # fungsi untuk menghitung luas dan keliling belah ketupat
    def onHitung(self, event=None):

        # perhitungan dengan metode Pemrograman Tidak Terstruktur 
        diagonal1 = int(self.txtDiagonal_1.get())
        diagonal2 = int(self.txtDiagonal_2.get())
        sisi = int(self.txtSisi.get())

        ketupat = belahketupat(diagonal1, diagonal2, sisi)
        luas = ketupat.luas()
        kel = ketupat.keliling()
        
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))

    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()

class belahketupat():
    # perhitungan dengan metode Pemrograman OOP
    def __init__(self, diagonal1, diagonal2, sisi):
        self.diagonal1 = diagonal1
        self.diagonal2 = diagonal2
        self.sisi = sisi

    def luas(self):
        return 0.5 * self.diagonal1 * self.diagonal2

    def keliling(self):
        return 4 * self.sisi
        
if __name__ == '__main__':
    root = Tk() 
    aplikasi = FrmBelah_Ketupat(root, "(OOP) Program Luas dan Keliling Belah Ketupat")
    root.mainloop()