def check_rhythm(poem):
    words = poem.split()  # Разделяем стихотворение на слова
    num_vowels = []  # Список, куда будем складывать число гласных букв в каждой фразе
    
    for word in words:
        # Удаляем из слова дефисы и приводим к нижнему регистру
        word = word.replace('-', '').lower()
        num_vowels.append(sum(1 for letter in word if letter in 'aeiouy'))
    
    # Если все элементы списка num_vowels равны между собой, то ритм есть
    if len(set(num_vowels)) == 1:
        return 'Парам пам-пам'
    else:
        return 'Пам парам'