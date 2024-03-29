from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W

class FrmPersegiPanjang:
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
        Label(mainFrame, text='Panjang Alas:').grid(row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Lebar:").grid(row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=3, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=4, column=0, sticky=W, padx=5, pady=5)
        
        # pasang textbox
        self.txtPanjang = Entry(mainFrame)
        self.txtPanjang.grid(row=0, column=1, padx=5, pady=5)
        self.txtLebar = Entry(mainFrame)
        self.txtLebar.grid(row=1, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=3, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=4, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.Hitung)
        self.btnHitung.grid(row=2, column=1, padx=5, pady=5)
    
    # fungsi untuk menghitung luas dan keliling persegi panjang
    def Hitung(self, event=None):

        panjang = int(self.txtPanjang.get())
        lebar = int(self.txtLebar.get())

        pp = persegipanjang(panjang, lebar)
        luas = pp.luas()
        kel = pp.keliling()
        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        self.txtKeliling.delete(0, END)
        self.txtKeliling.insert(END, str(kel))

    def Keluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()

class persegipanjang():
    # perhitungan dengan metode Pemrograman OOP
    def __init__(self, panjang, lebar):
        self.panjang = panjang
        self.lebar = lebar

    def luas(self):
        return self.panjang * self.lebar

    def keliling(self):
        return (2 * self.panjang) + (2 * self.lebar)


if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmPersegiPanjang(root, "(OOP) Program Luas dan Keliling Persegi Panjang")
    root.mainloop()