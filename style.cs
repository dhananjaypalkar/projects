/*===== MENU SHOW =====*/
const showMenu = (toggleId, navId) => {
    const toggle = document.getElementById(toggleId),
          nav = document.getElementById(navId);

    if (toggle && nav) {
        toggle.addEventListener('click', () => {
            nav.classList.toggle('show');
        });
    }
};
showMenu('nav-toggle', 'nav-menu');

/*==================== REMOVE MENU MOBILE ====================*/
const navLinks = document.querySelectorAll('.nav__link');

function linkAction(sectionId) {
    const navMenu = document.getElementById('nav-menu');
    // When a nav__link is clicked, remove the show-menu class and scroll to the corresponding section
    navMenu.classList.remove('show');

    const section = document.getElementById(sectionId);
    section.scrollIntoView({ behavior: 'smooth' });
}

navLinks.forEach((link) => {
    link.addEventListener('click', () => {
        const sectionId = link.getAttribute('href').substring(1); // Extract section ID from href
        linkAction(sectionId);
    });
});

/*==================== SCROLL REVEAL ANIMATION ====================*/
const sr = ScrollReveal({
    origin: 'top',
    distance: '60px',
    duration: 2000,
    delay: 200,
});

sr.reveal('.home__data, .about__img, .skills__subtitle, .skills__text', {});
sr.reveal('.home__img, .about__subtitle, .about__text, .skills__img', { delay: 400 });
sr.reveal('.home__social-icon', { interval: 200 });
sr.reveal('.skills__data, .work__img, .contact__input', { interval: 200 });