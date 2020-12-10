# OpenClosedPrincipal
Penjelasan mengenai OCP dimana entitas perangkat lunak (kelas, modul, fungsi, dll.) harus dibuka untuk ekstensi, tapi ditutup untuk modifikasi.

## About This Program
- Pada Source Code ini terdapat 2 program, yakni yang menggunakan prinsip OCP seperti diatas dan tanpa menggunakan OCP
- Program ini berjalan pada console, sehingga jalankan dengan *Run Without Debug*
- Pada bagian Coupon Without OCP, jika kalian mengubah salah satu fungsi maka akan memengaruhi fungsi lain
- Sedangkan pada bagian Coupon With OCP, karena menggunakan Abstraction kita dapat mengubah object menjadi object lain tanpa harus meninggalkan fungsi sesungguhnya