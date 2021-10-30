export function myfunction() {
    let markdown = document.getElementById('blog-markdown-body');
    for (let i = 0; i < markdown.childElementCount; i++) {
        const element = markdown.children[i];
        switch (element.tagName) {
            case 'H1':
                printTitle(1, element);
                break;
            case 'H2':
                printTitle(2, element);
                break;
            case 'H3':
                printTitle(3, element);
                break;
            case 'H4':
                printTitle(4, element);
                break;
            case 'H5':
                printTitle(5, element);
                break;
            case 'H6':
                printTitle(6, element);
                break;
            default:
                break;
        }
    }
}

function printTitle(headerTag, element) {
    let toc = document.getElementById('blog-markdown-toc');
    toc.setAttribute('style', 'font-size:0.5em;');
    let root = window.location.href.replace(window.location.hash,''); 
    toc.innerHTML += '<li  style=\'padding-left: ' + (headerTag - 1)*0.5 + 'rem;\'><a href=\'' + root + '#' + element.getAttribute('id') + '\'  target=\'_top\' >' + element.innerHTML + ' ' + '</a></li>';
    console.log(headerTag + ' ' + element.getAttribute('id'));
}