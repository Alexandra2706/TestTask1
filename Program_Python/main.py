import random

MAX_STRING_SIZE = 3
LETTERS = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz \
    0123456789{-}}[]., :();+='


def enter_array_param(msg):
    while True:
        try:
            number = int(input(msg))
            return number
        except ValueError:
            print('Ошибка ввода. Попробуйте еще раз')


def get_random_array(size, min_value, max_value):
    str_array = []
    for _ in range(size):
        str_length = random.randint(min_value, max_value)
        str_array.append(''.join(random.choice(LETTERS)
                                 for _ in range(str_length)))
    return str_array


def get_new_array(str_array):
    new_array = [item for item in str_array if len(item) <= MAX_STRING_SIZE]
    return new_array


if __name__ == '__main__':
    arr_size = abs(enter_array_param('Введите размер массива: '))
    min_value = abs(enter_array_param(
        'Введите минимальнимальную длину строки: '))
    max_value = abs(enter_array_param('Введите максимальную длину строки: '))
    if (min_value > max_value):
        temp = min_value
        min_value = max_value
        max_value = temp

    string_array = get_random_array(arr_size, min_value, max_value)
    print(f'Исходный массив: {string_array}')
    new_array = get_new_array(string_array)
    print(f'Новый массив: {new_array}')
