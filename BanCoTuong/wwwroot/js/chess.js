// wwwroot/js/chess.js
document.addEventListener('DOMContentLoaded', function () {
    const pieces = document.querySelectorAll('.chess-piece');

    pieces.forEach(piece => {
        piece.addEventListener('dragstart', dragStart);
        piece.addEventListener('dragend', dragEnd);
    });

    const board = document.querySelector('.chess-board');
    board.addEventListener('dragover', dragOver);
    board.addEventListener('drop', drop);
});

let draggedPiece = null;

function dragStart(e) {
    draggedPiece = this;
    e.dataTransfer.setData('text/plain', ''); // Cần thiết cho Firefox
    setTimeout(() => this.style.opacity = '0.5', 0);
}

function dragEnd(e) {
    draggedPiece.style.opacity = '1';
}

function dragOver(e) {
    e.preventDefault();
}

function drop(e) {
    e.preventDefault();
    if (!draggedPiece) return;

    // Tính toán vị trí mới dựa trên tọa độ chuột
    const boardRect = e.currentTarget.getBoundingClientRect();
    const x = e.clientX - boardRect.left;
    const y = e.clientY - boardRect.top;

    // Làm tròn đến vị trí ô gần nhất
    // Điều chỉnh các giá trị này theo kích thước ô cờ của bạn
    const cellSize = 74;
    const newLeft = Math.round(x / cellSize) * cellSize;
    const newTop = Math.round(y / cellSize) * cellSize;

    // Kiểm tra xem nước đi có hợp lệ không (sẽ implement sau)
    if (isValidMove(draggedPiece, newLeft, newTop)) {
        draggedPiece.style.left = `${newLeft}px`;
        draggedPiece.style.top = `${newTop}px`;
    }

    draggedPiece = null;
}

function isValidMove(piece, newLeft, newTop) {
    // TODO: Implement kiểm tra nước đi hợp lệ
    return true;
}