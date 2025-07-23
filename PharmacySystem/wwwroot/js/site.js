// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

window.addEventListener("DOMContentLoaded", () => {
    const slider = document.getElementById('cardSlider');
    const leftArrow = document.querySelector('.arrow.left');
    const rightArrow = document.querySelector('.arrow.right');
    const scrollAmount = 300;

    // Clone first & last cards for loop illusion
    const cards = slider.children;
    const first = cards[0].cloneNode(true);
    const last = cards[cards.length - 1].cloneNode(true);

    slider.appendChild(first); // add clone of first at the end
    slider.insertBefore(last, cards[0]); // add clone of last at the beginning

    // Offset scroll position to the "real" first card
    slider.scrollLeft = scrollAmount;

    let isThrottled = false; // debounce to avoid rapid clicks

    leftArrow.addEventListener('click', () => {
        if (isThrottled) return;
        isThrottled = true;

        slider.scrollBy({ left: -scrollAmount, behavior: 'smooth' });

        setTimeout(() => {
            if (slider.scrollLeft <= 0) {
                slider.scrollLeft = slider.scrollWidth - scrollAmount * 2;
            }
            isThrottled = false;
        }, 400); // match smooth scroll duration
    });

    rightArrow.addEventListener('click', () => {
        if (isThrottled) return;
        isThrottled = true;

        slider.scrollBy({ left: scrollAmount, behavior: 'smooth' });

        setTimeout(() => {
            if (slider.scrollLeft >= slider.scrollWidth - slider.clientWidth) {
                slider.scrollLeft = scrollAmount;
            }
            isThrottled = false;
        }, 400);
    });
});

document.getElementById('allergy-container').addEventListener('click', function (e) {
    if (e.target.classList.contains('add-btn')) {
        const firstRow = this.querySelector('.allergy-row');
        const clone = firstRow.cloneNode(true);

        // Reset the dropdown
        clone.querySelector('select').selectedIndex = 0;

        // Replace buttons with both + and -
        const buttonCol = clone.querySelector('.col-md-2');
        buttonCol.innerHTML = `
      <button type="button" class="add-btn btn btn-success">+</button>
      <button type="button" class="remove-btn btn btn-danger">–</button>
    `;

        this.appendChild(clone);
    }

    if (e.target.classList.contains('remove-btn')) {
        const row = e.target.closest('.allergy-row');
        row.remove();
    }
});
