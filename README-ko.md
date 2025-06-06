[English](README.md) | **한국어 (기계 번역)**
# DiffSinger "K-Pop" 포네마이저
## 자주 묻는 질문
### 이게 뭔가요?
이들은 DiffSinger 모델을 위해 만들어진 음소이며, 같은 트랙에서 한국어와 영어 가사를 쉽게 합치기 위해 만들어졌습니다. 저는 이것을 "K-Pop 포니마이저"라고 부르는데, 같은 노래에서 한국어와 영어를 사용하는 것이 한국 팝 음악에서 흔하기 때문입니다.
### 어떻게 작동하나요?
간단합니다:
- 한글 가사를 입력하면 한국어 연음 규칙을 사용하여 음소를 그에 맞게 변환합니다. 즉, 한글 가사를 그대로 입력할 수 있습니다(대부분의 경우).
- 영어 가사를 입력하면 다른 영어 음소 변환기와 마찬가지로 내장된 영어 G2P를 사용하여 가사를 음소로 구문 분석합니다.
### 기본 ARPABET 또는 ARPABET Plus를 지원하시나요?
둘 다 지원됩니다. 사전 빌드된 DLL 파일에는 두 개의 포니마이저이 포함되어 있으며, 각각 다른 G2P에 맞춰져 있습니다.
### 이 포니마이저는 어떤 사전 이름을 사용합니까?
먼저 `dsdict-ko+en.yaml`을 찾은 다음, 존재하지 않으면 `dsdict.yaml`로 돌아갑니다. 이 저장소에는 기본 사전이 제공됩니다 (multidict 해당).
### 제 모델은 multidict입니다. 이 포니마이저는 어떤 langcode를 사용합니까?
직관에 반하는 것처럼 들릴 수 있지만 영어는 음성 힌트가 필요할 가능성이 더 높기 때문에 `en`을 사용했습니다. 반면 한국어의 경우 한글을 음성적으로 입력하거나 가사 앞에 "!"를 붙여 기본 음소 구문 분석을 무시할 수 있습니다(예: 음절 사이에 들리는 "h" 음소를 원하는 경우). 이는 다소 경고이지만 지금은 이것이 최선의 해결책이라고 생각했습니다.
## 특별 감사
- [@EX3exp](https://github.com/ex3exp) 한국어 연음 구현에 대해.
- [@Cadlaxa](https://github.com/Cadlaxa/) 관련 ARPABET Plus 코드에 대해.