# mobilegame (çalışma adı)

Yönetim/strateji katmanı (kadro, taktik, transfer, maç yönetimi) ile arcade futbol
beceri mini-oyunlarını (şut, çalım, gol) birleştiren mobil futbol oyunu.

## Teknoloji

- **Engine:** Unity 6.3 LTS, Universal Render Pipeline (URP)
- **Dil:** C#
- **Platformlar:** Android + iOS
- **Görsel stil:** 2.5D (3D modeller, sabit/hafif açılı kamera)

## Kuruluma katılmak için

1. [Unity Hub](https://unity.com/download) indirip kur.
2. Unity Hub > Installs > **Unity 6.3 LTS** sürümünü kur. Modül seçim ekranında
   **Android Build Support** ve **iOS Build Support**'u işaretlemeyi unutma.
3. Repoyu klonla:
   ```
   git clone https://github.com/emirhankaratayy/mobilegame.git
   cd mobilegame
   git checkout claude/cloud-based-work-1dn6ky
   ```
4. Unity Hub'da **Open** ile klonladığın `mobilegame` klasörünü proje olarak aç.
5. Editor ilk açılışta paketleri/asset'leri import edecek, birkaç dakika sürebilir.

## Proje yapısı

- `Assets/Scripts` — oyun mantığı (C#)
- `Assets/Scenes` — sahneler
- `Assets/Prefabs` — yeniden kullanılabilir oyun nesneleri
- `Assets/Art` — modeller, texture'lar, animasyonlar
- `Assets/UI` — arayüz asset'leri
