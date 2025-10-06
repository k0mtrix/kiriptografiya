# Vegenir shifrlash usuli
# 04.10.2025
# muallif: Komiljon


matn=input("Matn:")
kalit=input("Kalit:")
chars=['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j','k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't','u', 'v', 'w', 'x', 'y', 'z']
matn=matn.lower()
kalit=kalit.lower()
belgilar=list(matn)
key=list(kalit)
shifr=''
deshifr=''
for i in range(len(belgilar)):
    if belgilar[i] in chars:
        m_index=chars.index(belgilar[i])
        k_index=chars.index(key[i%len(key)])
        sh_index=(m_index+k_index)%len(chars)
        shifr+=chars[sh_index]     
    else :
        shifr+=belgilar[i]
print(f'Shifrlangan matn >> {shifr}\nMantnni deshifrlaysizmi:(y,n)')
a=input('>>')
if a=='y':
    shifr_matn=input('Shifrlangan matnni kiriting: ')
    belgi=list(shifr_matn)
    for j in range(len(belgi)):
        if belgi[j] in chars:
            de_index=chars.index(belgi[j])
            ke_index=chars.index(key[j%len(key)])
            desh_index=(de_index-ke_index)%len(chars)
            deshifr+=chars[desh_index]            
        else:
            deshifr+=belgi[j]            
    deshifr=deshifr.title()
    print(f'Deshifrlangan matn >> {deshifr}')
else :
    print("Dastur to'xtadi")