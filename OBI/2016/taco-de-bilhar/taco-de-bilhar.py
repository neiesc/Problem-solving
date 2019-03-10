# https://olimpiada.ic.unicamp.br/pratique/p1/2016/f1/tacos-bilhar/

tacos=[]
fabricados=0
c=int(input())
comprimento_dos_tacos=list(map(int,input().rstrip().split()))
for taco in comprimento_dos_tacos:
    if taco in tacos:
        tacos.remove(taco)
    else:
        tacos.append(taco)
        fabricados+=2

print(fabricados)