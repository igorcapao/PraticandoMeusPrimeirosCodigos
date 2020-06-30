perguntas = {
    'Pergunta 1': {
        'pergunta': 'Quanto é 2 + 2?',
        'respostas': {'a': '1', 'b': '4', 'c': '5', },
        'resposta_certa': 'b',
    },
    'Pergunta 2': {
        'pergunta': 'Quanto é 3 * 2?',
        'respostas': {'a': '4', 'b': '10', 'c': '6', },
        'resposta_certa': 'c',
    },
    'Pergunta 3': {
        'pergunta': 'Quanto é 2 / 2?',
        'respostas': {'a': '4', 'b': '1', 'c': '6', },
        'resposta_certa': 'b',
    },
    'Pergunta 4': {
        'pergunta': 'Quanto é 1 + 2?',
        'respostas': {'a': '4', 'b': '43', 'c': '3', },
        'resposta_certa': 'c',
    },
    'Pergunta 5': {
        'pergunta': 'Quanto é 15 - 5?',
        'respostas': {'a': '10', 'b': '9', 'c': '6', },
        'resposta_certa': 'a',
    },
}
print()

respostas_certas = 0
for pk, pv in perguntas.items():
    print(f'{pk}: {pv["pergunta"]}')

    print('Opções: ')
    for rk, rv in pv['respostas'].items():
        print(f'[{rk}]: {rv}')

    resposta_usuario = input('Sua resposta: ')

    if resposta_usuario == pv['resposta_certa']:
        print('Você acertou!')
        respostas_certas += 1
    else:
        print('Você errou!')
    print()

qtd_perguntas = len(perguntas)
porcentagem_acerto = respostas_certas / qtd_perguntas * 100

if respostas_certas > 0:
    print(f'Você acertou {respostas_certas} pergunta(s).')
else:
    print('Você não acertou nenhuma pergunta')
print(f'Sua porcentagem de acerto foi de {porcentagem_acerto:.0f}%.')
