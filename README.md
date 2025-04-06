**English** | [한국어 (기계 번역)](README-ko.md)
# DiffSinger "K-Pop" Phonemizers
## FAQ
### What is this?
These are phonemizers made for DiffSinger models, for easily combining Hangeul and English lyrics on the same track. I called them "K-Pop phonemizers" since using Korean and English in the same song is common in Korean pop music.
### How do they work?
Simple:
- When you type Hangeul lyrics, it will use Korean sandhi rules to transform phonemes accordingly. This means you can type Hangeul lyrics as-is (most of the time).
- When you type in English lyrics, it will use the in-built English G2Ps to parse the lyrics to phonemes, just like any other English phonemizer would.
### Does this support basic ARPABET only? Or ARPABET Plus?
It supports both. The pre-built DLL file contains two phonemizers, each tailored to the different G2Ps.
### What dictionary name do these phonemizers use?
It looks for `dsdict-ko+en.yaml` first, then falls back to `dsdict.yaml` if it doesn't exist. A base dictionary is provided in this repository (multidict only).
### My model is multidict. Which langcode does this phonemizer use?
It might sound counterintuitive, but I went with `en` due to the fact that English has a higher chance of needing phonetic hints. Whereas with Korean, you can either type Hangeul phonetically, or prefix the lyric with "!" to override the default phoneme parsing (e.g. if you want to have an audible "h" phoneme between syllables). This is somewhat of a caveat but I thought it would be the best solution for now.
### I'm not Korean, I'm on Windows, and I need a Korean Keyboard.
No problem. I highly recommend [Nalgaeset](http://moogi.new21.org/en/ngs/) for non-Korean Windows users. This keyboard supports romaja input.
## Special thanks
- [@EX3exp](https://github.com/ex3exp) for the Korean sandhi implementation.
- [@Cadlaxa](https://github.com/Cadlaxa/) for the related ARPABET Plus code.